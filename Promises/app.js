var p = new Promise(function(resolve, reject){
	reject("some data");
});

var p2 = p.then(function(result){
	console.log("yeah, got resolved " + result );
	return result + " some more data";
},
	function(error){
		console.log("oh no, rejected");
		throw new Error("SOME ERROR");
	}
);

p2.then(function(result){
	console.log("p2, got resolved" + result);
},
function(error){
	console.log("noooo, p2, got rejected");
})


