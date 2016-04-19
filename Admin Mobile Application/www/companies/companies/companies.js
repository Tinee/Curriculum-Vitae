(function() {
    'use strict';

    angular
        .module('app.companies')
        .controller('CompaniesController', CompaniesController);

    CompaniesController.$inject = ['dataservice', '$scope', '$ionicModal'];
    function CompaniesController(dataservice, $scope, $ionicModal) {
        var vm = this;

        vm.personalLetters = [];
        vm.doRefresh = doRefresh;
        vm.triggerModal = triggerModal;
        $scope.closeModal = closeModal;

        activate();


        ////////////////

        function activate() {

            var storageItem = JSON.parse(window.localStorage.getItem('personalLetters'));

            if (storageItem) {
                vm.personalLetters = storageItem.personalLetters;
            }
            else {
                dataservice.personalLetters().query(function(response) {
                    window.localStorage.setItem('personalLetters', angular.toJson({ personalLetters: response }));
                    vm.personalLetters = response;
                });
            }
        }

        function triggerModal() {

            $ionicModal.fromTemplateUrl('./companies/companies/addCompany.html', {
                scope: $scope,
                animation: 'slide-in-up',
                hardwareBackButtonClose: false
            }).then(function(modal) {
                $scope.modal = modal;
                $scope.modal.show();
            });
        };

        function closeModal() {
            $scope.modal.hide();
        };

        function doRefresh() {
            var newData = dataservice.personalLetters().query(function(response) {

                window.localStorage.removeItem('personalLetters');
                window.localStorage.setItem('personalLetters', angular.toJson({ personalLetters: response }));
                vm.personalLetters = response;
                $scope.$broadcast('scroll.refreshComplete');

            });
        }

    }
})();

