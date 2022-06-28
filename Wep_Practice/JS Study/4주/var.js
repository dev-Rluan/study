// var : 함수 유효범위
// let, const : 블록 유효범이


// var
var foo = 2;
var foo = 3;
let lfoo = 1;
console.log(foo);
if (1 < 2){
    let lfoo = 2;
    console.log('lfoo = : ',lfoo);
    lfoo = 3;
}
console.log('lfoo = : ',lfoo);

// var: 영역(scope) 벗어나도 변경된 값 유지
// let과 범위(scope)가 다르다

var foo = 'foo1';
console.log(foo);       // foo1
if(1){
    var foo = 'foo2'
    console.log(foo);   // foo2
}
console.log(foo);       // foo2

// let
let boo = 2;
// let boo = 3;         // error
 
console.log(boo);

// const
const a= 0;
// a = 1;               // error
console.log(a);

// let : if 벗어나면 if문 안에서 선언된 bar와 다른 bar
let bar = 'bar1';
console.log(bar);       // bar1
if(1){
    let bar ="bar2";
    console.log(bar);   // bar2
}
console.log(bar);       // bar1
