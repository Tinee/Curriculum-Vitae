(function() {
'use strict';

   angular
      .module('app.core')
      .factory('dataservice', dataservice);

   dataservice.$inject = ['$resource'];
   function dataservice($resource) {
      var baseAdress = 'http://marcuscarlssonapi.azurewebsites.net/';

        var services = {
           personalLetters:personalLetters,
           technicians: technicians
        };

        return services;

        ////////////////

        function personalLetters() {
            return $resource(baseAdress + 'api/personalletter/:companyKey', { companyKey: '@companyKey' });
        }

         function technicians() {
            return $resource(baseAdress + 'api/technician/:technicianId', { technicianId: '@technicianId' });
        }
   }
})();