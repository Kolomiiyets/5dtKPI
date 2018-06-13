const net = require("net");
const express = require("express");
var url = require("url");

const app = express();
const client = new net.Socket();

let NOWdata;
let NOWRotate;

client.connect(80, "10.10.10.10", () => {
  console.log("Connected");
});

client.on("data", data => {
  data = String(data);

  data = JSON.parse(data);

  console.log(data);

  NOWdata = data;
});

// express

app.post("/dataset", (req, res) => {
  let url_parts = url.parse(req.url, true);
  let query = url_parts.query;

  console.log(query);

  NOWRotate = query;

  res.end();
});

app.get("/data", function(req, res) {
  res.header("Access-Control-Allow-Origin", "*");
  res.header(
    "Access-Control-Allow-Headers",
    "Origin, X-Requested-With, Content-Type, Accept"
  );

  res.send({ NOWdata, NOWRotate });
});

app.get("/", function(req, res) {
  res.send("Server 5DT");
});

app.listen(3000, () => {
  console.log("Example app listening on port 3000!");
});
