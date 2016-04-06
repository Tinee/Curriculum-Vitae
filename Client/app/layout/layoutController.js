(function() {
   'use strict';

   angular
      .module('layout.module')
      .controller('LayoutController', LayoutController);

   LayoutController.$inject = ['levelbar', 'dataservice','toastr'];
   function LayoutController(levelbar, dataservice,toastr) {
      var vm = this;


      activate();

      vm.personalLetter = null;
      vm.foundLetter = false;
      vm.companyKey = "";

      vm.getPersonalLetter = getPersonalLetter;
      vm.openModal = openModal;

      ////////////////

      function activate() {
         levelbar.getValues();
         openModal();
      }

      function openModal() {
         $("#myModal").modal();
      }

      function getPersonalLetter(companyKey) {
         dataservice.personalLetters().get({ companyKey: companyKey }, function(response) {
            
            vm.personalLetter = response;
            vm.foundLetter = true;
            
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