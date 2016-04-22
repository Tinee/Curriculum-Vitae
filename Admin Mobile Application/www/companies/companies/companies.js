(function () {
    'use strict';

    angular
        .module('app.companies')
        .controller('CompaniesController', CompaniesController);

    CompaniesController.$inject = ['dataservice', '$scope', '$ionicModal', '$ionicPopup'];
    function CompaniesController(dataservice, $scope, $ionicModal, $ionicPopup) {
        var vm = this;

        vm.companies = [];
        vm.doRefresh = doRefresh;
        vm.triggerModal = triggerModal;
        vm.removeCompany = removeCompany;

        $scope.newCompany = {
            name: "",
            website: ""
        };

        $scope.closeModal = closeModal;
        $scope.addCompany = addCompany;

        activate();

        ////////////////

        function activate() {
            isDataInStorageGetIt();
        }

        function isDataInStorageGetIt() {
            var storageItem = JSON.parse(window.localStorage.getItem('companies'));

            if (storageItem) {
                vm.companies = storageItem.companies;
            }
            else {
                dataservice.companies().query(function (response) {
                    window.localStorage.setItem('companies', angular.toJson({ personalLetters: response }));
                    vm.companies = response;
                });
            }
        }

        function triggerModal() {

            $ionicModal.fromTemplateUrl('./companies/addCompany/addCompany.html', {
                scope: $scope,
                animation: 'slide-in-up',
                hardwareBackButtonClose: false
            }).then(function (modal) {
                $scope.modal = modal;
                $scope.modal.show();
            });
        }

        function closeModal() {
            $scope.modal.remove();
        }

        function addCompany() {

            var companyName = $scope.newCompany.name;
            var companyWebsite = $scope.newCompany.website;

            dataservice.companies().save({ Name: companyName, Website: companyWebsite }, function (response) {
                closeModal();
                doRefresh();
            });
        }

        function removeCompany(companyId) {
            var confirmResponse = showConfirmPopup('Delete Company', 'Are you sure you want to delete this?');

            confirmResponse.then(function (response) {
                if (response) {
                    dataservice.companies().delete({ id: companyId }, function () {
                        doRefresh();
                    });
                }
            });
        }

        function doRefresh() {
            var newData = dataservice.companies().query(function (response) {

                window.localStorage.removeItem('companies');
                window.localStorage.setItem('companies', angular.toJson({ companies: response }));
                vm.companies = response;
                $scope.$broadcast('scroll.refreshComplete');
            });
        }

        function showConfirmPopup(title, body) {
            return $ionicPopup.confirm({
                title: title,
                template: body
            });
        }
    }
})();

