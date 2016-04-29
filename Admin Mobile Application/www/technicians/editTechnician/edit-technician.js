(function () {
    'use strict';

    angular
        .module('app.technicians')
        .controller('EditTechnicianController', EditTechnicianController);

    EditTechnicianController.$inject = ['dataservice', '$stateParams','$ionicHistory'];
    function EditTechnicianController(dataservice, $stateParams,$ionicHistory) {
        var vm = this;



        vm.TechnicianToEdit = {
            Name: "",
            Percentage: 0,
            Type: 0
        };
        
        vm.editTechnician = editTechnician;

        activate();
        ////////////////

        function activate() {
            getTechnicianToEdit();
        }
        
        function editTechnician()
        {
            dataservice.technicians().save(vm.TechnicianToEdit) ;
            $ionicHistory.goBack();
        }

        function getTechnicianToEdit() {
            
            dataservice.technicians().get({ id: $stateParams.id }, function (response) {
                vm.TechnicianToEdit = response;
            }, function () {
                
            });
        }
    }
})();