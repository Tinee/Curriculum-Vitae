(function () {
    'use strict';

    angular
        .module('app.companies')
        .controller('CompanyDetailController', CompanyDetailController);

    CompanyDetailController.$inject = ['$stateParams', 'dataservice'];
    function CompanyDetailController($stateParams, dataservice) {
        var vm = this;


        vm.data = {};
        vm.companyNotFound = false;
    

        activate();


        ////////////////

        function activate() {
            getCompany();
        }

        function getCompany() {

            dataservice.personalLetterByCompanyId().get({ id: $stateParams.id }, function (response) {
                vm.data = response;
            }, function () {

                vm.companyNotFound = true;
            });
        }
    }
})();