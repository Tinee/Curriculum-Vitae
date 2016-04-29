(function () {
    'use strict';

    angular
        .module('app.companies')
        .controller('CompanyDetailController', CompanyDetailController);

    CompanyDetailController.$inject = ['$stateParams', 'dataservice', '$ionicModal','$scope'];
    function CompanyDetailController($stateParams, dataservice, $ionicModal,$scope) {
        var vm = this;


        vm.data = {};
        vm.companyNotFound = false;
        vm.triggerModal = triggerModal;

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

        function triggerModal() {

            $ionicModal.fromTemplateUrl('./companies/addLetter/add-letter.html', {
                scope: $scope,
                animation: 'slide-in-up',
                hardwareBackButtonClose: false
            }).then(function (modal) {
                $scope.modal = modal;
                $scope.modal.show();
            });
        }
    }
})();