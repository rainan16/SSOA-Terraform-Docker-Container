const express = require('express');
const nation = require('./nation.js');
const app = express();
const port = 3001;

app.use(express.urlencoded({
    extended: true
}));

app.listen(port, () => {
    console.log(`Server started and listening on port: ${port}`);
});

app.get('/', async function (req, res) {
    const json = await nation(req, res)
    res.send(json);
});