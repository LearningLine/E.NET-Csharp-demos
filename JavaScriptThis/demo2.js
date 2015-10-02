var Person = function(name, age){
	this.name = name;
	this.age = age;
};

Person.prototype.numberOfFingers = 10;
Person.prototype.canDrink = function()
	{
		return this.age >=21;
	};
	
	
var p = new Person("Alice",32);

p.numberOfFingers //10;

var p2 = new Person("Bob", 12);
p.numberOfFingers = 9;

p2.numberOfFingers // 10;

console.log("Can alice drink: " + p.canDrink());
