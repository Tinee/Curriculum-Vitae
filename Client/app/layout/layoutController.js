(function () {
    'use strict';

    angular
        .module('layout.module')
        .controller('LayoutController', LayoutController);

    LayoutController.$inject = ['levelbar', 'dataservice', 'toastr', 'localStorageService', '$scope', 'blockUI', 'courses'];
    function LayoutController(levelbar, dataservice, toastr, localStorageService, $scope, blockUI, courses) {
        var vm = this;

        vm.personalLetter = null;
        vm.foundLetter = false;
        vm.companyKey = "";
        vm.courses = courses.get();

        vm.getPersonalLetter = getPersonalLetter;
        vm.openModal = openModal;
        vm.removeLocalStorageItem = removeLocalStorageItem;

        activate();

        ////////////////

        $scope.$on('ngRepeatFinished', function (ngRepeatFinishedEvent) {
            levelbar.getValues();
            $(function () {
                $('[data-toggle="tooltip"]').tooltip();
            });
        });

        function activate() {

            var personalLetter = getLocalStorage('personalLetter')
            if (personalLetter === null) {
                $("#myModal").modal();
            }
            else {
                vm.foundLetter = true;
                vm.personalLetter = personalLetter;
            }

            getTechnicians();
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

        function getTechnicians() {
            vm.technicians = dataservice.technicians().query(function (response) {
            });
        }

        function getPersonalLetter(companyKey) {
            blockUI.start();
            dataservice.personalLetters().get({ companyKey: companyKey }, function (response) {

                vm.personalLetter = response;
                vm.foundLetter = true;
                localStorageService.set('personalLetter', vm.personalLetter);

                blockUI.stop();

                $('#myModal').modal('hide');
                toastr.success('Erat personliga brev ligger nu på hemsidan.', 'Hej ' + vm.personalLetter.Company.Name, {
                    timeOut: 6000,
                    closeButton: false
                });

            }, function (err) {

                toastr.error('Kunde inte hitta det personliga brevet.', 'Fel', {
                    timeOut: 6000,
                    closeButton: true
                });
            });
        }
    }
}
)();