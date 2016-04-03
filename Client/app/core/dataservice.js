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
           company:company
        };

        return services;

        ////////////////
        
        function personalLetters() {
            return $resource(baseAdress + 'api/personalletters/:id', { id: '@id' });
        }
        
        function company() {
            return $resource(baseAdress + 'api/company/:id', { id: '@id' });
        }
   }
})();