(function() {
   'use strict';

   angular
      .module('layout.module')
      .controller('LayoutController', LayoutController);

   LayoutController.$inject = ['levelbar', 'dataservice', 'toastr', 'localStorageService'];
   function LayoutController(levelbar, dataservice, toastr, localStorageService) {
      var vm = this;

      var localStoragePersonalLetter =
         vm.personalLetter = null;
      vm.foundLetter = false;
      vm.companyKey = "";

      vm.getPersonalLetter = getPersonalLetter;
      vm.openModal = openModal;
      vm.removeLocalStorageItem = removeLocalStorageItem;

      activate();

      ////////////////

      function activate() {
         levelbar.getValues();
         var personalLetter = getLocalStorage('personalLetter')
         if (personalLetter === null) {
            $("#myModal").modal();

         }
         {
            vm.foundLetter = true;
            vm.personalLetter = personalLetter;
         }
      }

      function openModal() {
         var personalLetter = getLocalStorage('personalLetter')

         if (personalLetter === null) {
            $("#myModal").modal();
         }
         else {
            vm.foundLetter = true;
         }
      }

      function removeLocalStorageItem(key) {
         localStorageService.remove(key);
         vm.foundLetter = false;
      }

      function getLocalStorage(key) {
         return localStorageService.get(key);
      }

      function getPersonalLetter(companyKey) {

         dataservice.personalLetters().get({ companyKey: companyKey }, function(response) {

            vm.personalLetter = response;
            vm.foundLetter = true;
            localStorageService.set('personalLetter', vm.personalLetter);

            $('#myModal').modal('hide');
            toastr.success('Erat personliga brev ligger nu på hemsidan.', 'Hej ' + vm.personalLetter.Company.Name, {
               timeOut: 6000,
               closeButton: true
            });

         }, function(err) {

            toastr.error('Kunde inte hitta det personliga brevet.', 'Fel', {
               timeOut: 6000,
               closeButton: true
            });
         });
      }
   }
}
)();