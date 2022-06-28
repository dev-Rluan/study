const express = require("express");
let app = express();
const ejs = require("ejs");

var router = require("./routers/controller")(app);


const server = app.listen(3000, () => {
    console.log("Server on 3000");
})