'use strict'

const express = require('express');
const app = express();
const mysql = require("mysql");

let conn = mysql.createConnection({
    host: "localhost",
    database: "gallery_db",
    user: "root",
    password: "root"
});

conn.connect(function(err) {
    if(err) {
        console.log("Error connecting to db");
        return;
    }
    console.log("Connection established");
});

app.use('/src', express.static('src'));

app.get('/', (req, res) => {
    res.sendFile(__dirname + '/src/index.html');
});

app.get('/gallery', function(req, res) {
    conn.query('SELECT * FROM gallery', function(err, rows) {
        if(err) {
            console.log(err.toString());
            res.status(500).send('Database error');
            return;
        }
        res.json(rows.map((row) => {
            return {
                id: row.id,
                src: row.src,
                title: row.title,
                text: row.text
            }
        }));
    });
});

app.listen(8080);