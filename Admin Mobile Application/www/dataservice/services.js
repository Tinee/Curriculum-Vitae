angular.module('starter.services', [])

.factory('Chats', function() {
  // Might use a resource here that returns a JSON array

  // Some fake testing data
  var chats = [{
    id: 0,
    name: 'Andreas Karlsson',
    lastText: 'Me like Gustaf <3',
    face: 'https://scontent-ams3-1.xx.fbcdn.net/hphotos-xla1/v/t1.0-9/12301605_10153512861187740_1579971671822849027_n.jpg?oh=e282211caebe1dbb9ab960e5aaae5a6f&oe=57B350FA'
  }, {
    id: 1,
    name: 'Andre Cervin',
    lastText: 'Hello! Its me.',
    face: 'https://scontent-ams3-1.xx.fbcdn.net/hphotos-xfa1/v/t1.0-9/10407774_10204468628066990_8640887773495693192_n.jpg?oh=d10a113f5702e8ad772eceb0f44ad3c4&oe=5779774E'
  }, {
    id: 2,
    name: 'Gustaf Wahlberg',
    lastText: 'I like cars and boys.',
    face: 'https://scontent-ams3-1.xx.fbcdn.net/hprofile-xpt1/v/t1.0-1/c0.3.416.416/11891131_10204887877017485_8841078456185918063_n.jpg?oh=e5f61690e502b05c4cf5f4998b13d6d3&oe=57790427'
  }];

  return {
    all: function() {
      return chats;
    },
    remove: function(chat) {
      chats.splice(chats.indexOf(chat), 1);
    },
    get: function(chatId) {
      for (var i = 0; i < chats.length; i++) {
        if (chats[i].id === parseInt(chatId)) {
          return chats[i];
        }
      }
      return null;
    }
  };
});
