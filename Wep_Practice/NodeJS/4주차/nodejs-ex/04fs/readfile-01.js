// ./fs/readfile-01.js
//fs = FileSystem
const fs = require('fs');
// readFileSync : 동기방식 (다 읽을때까지 대기)
const file = fs.readFileSync('readme.txt', {
    encoding : 'utf-8'
});

console.log(file);