const cars = ['lamborghini', 'ferrari', 'aston martin', 'toyota']

cars.forEach(x => document.writeln(x.charAt(0).toUpperCase() + x.substring(1) + '<br>'))

const ar1 = [...Array(10).keys()].map(x => x++)
const ar2 = ['A','B','C',7.1]

const arResult = [...ar1, ...ar2]
const arResult2 = Array.prototype.concat(ar1, ar2)
const arResult3 = ar1.concat(ar2)
console.log(arResult);
console.log(arResult2);
console.log(arResult3);

const [uno, due, ...arRimanenti] = [...ar1, ...ar2]

console.log(uno + '<- uno |\n' + due + '<- due |\n' + arRimanenti + '<- rimanenti');