var express = require('express');
var app = express();

app.get('/', (req, res) => {    //res = respone 응답
    res.send('Hellow World!!!!!');
});

app.get('/', (req, res, next) => {    //res = respone 응답
    res.status(201).send('hello world!!');
});

app.get('/send', (req, res, next) => {    //res = respone 응답
    res.status(201).send('<h1>hello world!!</h1>');
});

app.get('/download', (req, res, next) => {    //res = respone 응답
    res.download('./test.txt');
});

app.get('/redirect', (req, res, next) => {    //res = respone 응답
    res.redirect('/send');
});

app.get('/json', (req, res, next) => {    //res = respone 응답
    res.json({message: 'succes', code: 0});
});

    
app.listen(3000,() => {
    console.log('Example App listening on port 3000');
})