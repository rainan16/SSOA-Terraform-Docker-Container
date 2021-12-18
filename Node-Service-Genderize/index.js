const express = require('express');
const gender = require('./gender.js');
const app = express();
const port = 3002;

app.use(express.urlencoded({
    extended: true
}));

app.listen(port, () => {
    console.log(`Server started and listening on port: ${port}`);
});

app.get('/', async function (req, res) {
    const json = await gender(req, res)
    res.send(json);
});