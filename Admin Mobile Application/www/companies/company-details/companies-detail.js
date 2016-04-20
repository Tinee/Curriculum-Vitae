(function () {
   'use strict';

   angular
      .module('app.companies')
      .controller('CompanyDetailController', CompanyDetailController);

   CompanyDetailController.$inject = ['$stateParams', 'dataservice'];
   function CompanyDetailController($stateParams, dataservice) {
      var vm = this;


      vm.data = {};

      activate();


      ////////////////

      function activate() {
         vm.data = dataservice.personalLetterByCompanyId().get({ id: $stateParams.id },function(){},function(){
            vm.data = {
               Company: {
                  Name: 'Not Found'
               }
            }
         });
      }
   }
})();