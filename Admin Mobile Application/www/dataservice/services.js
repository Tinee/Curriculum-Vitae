(function() {
'use strict';

  angular
    .module('app.services',[])
    .factory('dataservice', Service);

  Service.$inject = ['$resource'];
  function Service($resource) {
    
    var base = 'http://marcuscarlssonapi.azurewebsites.net/';
    
    var services = {
     companies:companies,
     personalLetters: personalLetters
    };
    
    return services;

    ////////////////
   function companies() {
            return $resource(base + 'api/companies/:id', { id: '@id' });
        }
        
         function personalLetters() {
            return $resource(base + 'api/personalletter/:id', { id: '@id' });
        }
  }
})();