(function () {
   'use strict';

   angular
      .module('app.companies')
      .controller('CompanyDetailController', CompanyDetailController);

   CompanyDetailController.$inject = ['$stateParams'];
   function CompanyDetailController($stateParams) {
      var vm = this;


      activate();
      

      ////////////////

      function activate() {
         var storageItem = JSON.parse(window.localStorage.getItem('personalLetters'));
         var clickedObject = storageItem.personalLetters[$stateParams.id];
         vm.data = clickedObject;
         
      }
   }
})();