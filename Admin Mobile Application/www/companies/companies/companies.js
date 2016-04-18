(function () {
   'use strict';

   angular
      .module('app.companies')
      .controller('CompaniesController', CompaniesController);

   CompaniesController.$inject = ['dataservice', '$scope'];
   function CompaniesController(dataservice, $scope) {
      var vm = this;

      vm.personalLetters = [];
      vm.doRefresh = doRefresh;

      activate(

      );
      ////////////////

      function activate() {

         var storageItem = JSON.parse(window.localStorage.getItem('personalLetters'));

         if (storageItem) {
            vm.personalLetters = storageItem.personalLetters;
         }
         else {
            dataservice.personalLetters().query(function (response) {
               window.localStorage.setItem('personalLetters', angular.toJson({ personalLetters: response }));
               vm.personalLetters = response;
            });
         }
      }

      function doRefresh() {
         var newData = dataservice.personalLetters().query(function (response) {
            
            window.localStorage.removeItem('personalLetters');
            window.localStorage.setItem('personalLetters', angular.toJson({ personalLetters: response }));
            vm.personalLetters = response;
            $scope.$broadcast('scroll.refreshComplete');
            
         });
      }

   }
})();

