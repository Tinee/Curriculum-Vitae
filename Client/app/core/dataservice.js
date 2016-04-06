(function() {
'use strict';

   angular
      .module('app.core')
      .factory('dataservice', dataservice);

   dataservice.$inject = ['$resource'];
   function dataservice($resource) {
      var baseAdress = 'http://localhost:2911/';

        var services = {
           personalLetters:personalLetters,
        };

        return services;

        ////////////////
        
        function personalLetters() {
            return $resource(baseAdress + 'api/personalletter/:companyKey', { companyKey: '@companyKey' });
        }
   }
})();