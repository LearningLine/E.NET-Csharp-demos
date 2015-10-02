console.log("Hello");

name = "Whatever";
var sayHelloFn = function()
{
	console.log(this.name);
}
var p = {name:"Alice",
	sayHello : function(){
	console.log(this.name);},
	grades : [15,23,12,12],
	showGrades : function(){
		var that = this;
		this.grades.forEach(function(item){
			console.log(item);
			console.log(that.name);
		});
	}
	/*showGrades2 : function(){
		this.grades.forEach((item) =>{
			console.log(item);
			console.log(this.name);
		});
	}*/
};

var p2 = {name:"Bob", sayHello : function(){
	console.log(this.name);
}
};

p.sayHello();
p2.sayHello();
p.showGrades();
p.sayHello = p2.sayHello;
p.sayHello();