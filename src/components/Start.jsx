import React, { Component, Fragment } from "react";

import CanvasOne from "./CanvasOne";
import CanvasFour from "./CanvasFour";

class Start extends Component {
  constructor(props) {
    super(props);

    this.state = {
      NOWdata: [],
      NOWRotate: { xPos: 0, yPos: 0 },
      rotate: false,
      scale: 0
    };

    this.upDate = this.upDate.bind(this);

    this.upDate();
  }

  upDate() {
    fetch("http://10.10.10.10:3000/data", { method: "GET", mode: "cors" })
      .then(response => {
        console.log("res: ", response);
        return response.json();
      })
      .then(data => {
        let scale = 0;

        if (
          //data.NOWdata[3] == 1 &&
          data.NOWdata[4] == 1 &&
          data.NOWdata[6] == 1 &&
          data.NOWdata[7] == 1 &&
          data.NOWdata[9] == 1 &&
          data.NOWdata[10] == 1
        ) {
          scale = -0.01;

          if (
            data.NOWdata[1] == 1 &&
            // data.NOWdata[3] == 1 &&
            data.NOWdata[4] == 1 &&
            data.NOWdata[6] == 1 &&
            data.NOWdata[7] == 1 &&
            data.NOWdata[9] == 1 &&
            data.NOWdata[10] == 1 &&
            data.NOWdata[12] == 1 &&
            data.NOWdata[13] == 1
          ) {
            scale = 0.01;
          }
        }

        this.setState({
          NOWdata: data.NOWdata,
          NOWRotate: data.NOWRotate,
          scale
        });

        this.upDate();
      })
      .catch(err => {
        console.error("Err: ", err);
      });
  }

  render() {
    return window.innerWidth > 700 ? (
      <CanvasOne
        NOWRotate={this.state.NOWRotate}
        rotate={this.state.rotate}
        scale={this.state.scale}
      />
    ) : (
      <CanvasFour
        NOWRotate={this.state.NOWRotate}
        rotate={this.state.rotate}
        scale={this.state.scale}
      />
    );
  }
}

export default Start;
