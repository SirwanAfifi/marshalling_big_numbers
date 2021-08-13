import * as express from "express";
import { Request, Response } from "express";

const app = express();

app.get("/api", (request: Request, response: Response) => {
  response.send({
    name: "API",
    count: BigInt(Number.MAX_SAFE_INTEGER).toString(),
  });
});

app.listen(3000, () => {
  console.log(`Connected on Port 3000`);
});
