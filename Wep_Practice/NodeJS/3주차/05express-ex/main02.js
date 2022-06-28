var express = require('express');
var app = express();

app.get('/', (req, res) => {    //res = respone 응답
    res.send('Hellow World');
});
app.get('/user/:id', (req, res) => {    //res = respone 응답
    res.send('Received a GET request, param:' + req.params.id);
});

app.post('/user', (req, res) => {    //res = respone 응답
    res.json({success: true});
});

app.put('/user', (req, res) => {    //res = respone 응답
    res.status(400).json({message : 'Hey, you. Bad Request'});
});
app.delete('/user', (req, res) => {    //res = respone 응답
    res.send('Received a DELETE request');
});
    
app.listen(3000,() => {
    console.log('Example App listening on port 3000');
})