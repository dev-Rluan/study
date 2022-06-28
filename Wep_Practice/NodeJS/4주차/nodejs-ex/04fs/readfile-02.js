// ./fs/readfile-02.js
//fs = FileSystem
const fs = require('fs');

const callback = (err, file) => {
    console.log(file);
}

// readFile : 비동기방식 (다 읽기 전에 다음 작업 실행)
const file = fs.readFile('readme.txt', {
    encoding : 'utf-8'
}, callback);       // callback함수 : 호출함수(작업이 끝나면 호출되는 함수)    

console.log(file);  // 파일내용을 읽어주세요