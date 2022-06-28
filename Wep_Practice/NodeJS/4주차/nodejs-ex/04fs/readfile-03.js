// ./fs/readfile-02.js
//fs = FileSystem
const fs = require('fs');

// const callback = (err, file) => {
//     console.log(file);
// }

// readFile : 비동기방식 (다 읽기 전에 다음 작업 실행)
const file = fs.readFile('readme.txt', {
    encoding : 'utf-8'
}, (err, file) => console.log(file) );           

