var myApp = angular.module("myApp", []);
myApp.controller("MyController", function  ($scope){
    var person = person = {
        name:"Alice",
        age:23,
        "friends":[
            {
                name:"Bob", age: 25
            },
            {
                name:"Charlie", age:34
            }
        ]
    };
    $scope.person = person;
    $scope.fireFriends = function(){
        person.friends = []
    };
    $scope.addFriend = function(){
        person.friends.push({name:$scope.newFriendName});
    }
    $scope.calculator = 
    {
        a: 0,
        b: 0,
        sum: function(){
            return  parseFloat(this.a) + parseFloat(this.b);}
    }
});