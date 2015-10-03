var moviesApp = angular.module("moviesApp", []);

var moviesController = moviesApp.controller("moviesCtrl", function($scope, $http) {
    $scope.movies = [];
    $http.get("api/movies").success(function(result){
        $scope.movies = result.items;}).
    error(function() {
        alert("fail");
    });
});