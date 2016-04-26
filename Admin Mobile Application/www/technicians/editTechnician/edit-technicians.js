(function () {
   'use strict';

   angular
      .module('app.technicians')
      .controller('EditTechnicianController', EditTechnicianController);

   EditTechnicianController.$inject = ['dataservice','$stateParams'];
   function EditTechnicianController(dataservice,$stateParams) {
      var vm = this;



      vm.TechnicianToEdit = {
         Name: "",
         Percentage: 0,
         Type: 0
      };

       activate();
      ////////////////

      function activate() {
         getTechnicianToEdit();
      }

      function getTechnicianToEdit() {
           dataservice.technicians().get({ id: $stateParams.id }, function (response) {
                vm.TechnicianToEdit = response;
            }, function () {
            });
      }
   }
})();