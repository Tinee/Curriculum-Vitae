(function () {
    'use strict';

    angular
        .module('app.technicians')
        .controller('TechniciansController', TechniciansController);

    TechniciansController.$inject = ['dataservice', '$scope', '$ionicModal', '$ionicPopup', 'popup'];
    function TechniciansController(dataservice, $scope, $ionicModal, $ionicPopup, popup) {
        var vm = this;

        vm.technicians = [];

        $scope.newTechnician = {
            name: "",
            percentage: 0,
            type: 0
        };

        vm.triggerModal = triggerModal;
        $scope.closeModal = closeModal;
        $scope.addTechnician = addTechnician;
        $scope.removeTechnician = removeTechnician;

        activate();

        ////////////////

        function activate() {
            vm.technicians = getTechnicians();
        }

        function getTechnicians() {
            return dataservice.technicians().query(function (response) {
                return response;
            });
        }

        function addTechnician() {

            var nt = $scope.newTechnician;

            dataservice.technicians().save({ Name: nt.name, Percentage: nt.percentage, Type: nt.type }, function (response) {
                closeModal();
                 vm.technicians = getTechnicians();
            });
        }

        function removeTechnician(technicianId) {
            var confirmResponse = popup.confirmPopup('Delete Technician', 'Are you sure you want to delete this?');

            confirmResponse.then(function (response) {
                if (response) {
                    dataservice.technicians().delete({ id: technicianId }, function () {
                        vm.technicians = getTechnicians();
                    });
                }
            });
        }

        function triggerModal() {

            $ionicModal.fromTemplateUrl('./technicians/addTechnician/addTechnician.html', {
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

    }
})();