import React, { Component, Fragment } from "react";
import * as THREE from "three";

class CanvasOne extends Component {
  constructor(props) {
    super(props);

    this.state = {};

    var scene = new THREE.Scene();
    scene.background = new THREE.Color(0xffffff);

    var camera = new THREE.PerspectiveCamera(
      75,
      window.innerWidth / window.innerHeight,
      0.1,
      1000
    );

    var renderer = new THREE.WebGLRenderer();

    //renderer.setClearColor(0xffffff, 0);
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    var cube = new THREE.Mesh(
      new THREE.SphereBufferGeometry(1, 16, 8),
      new THREE.MeshBasicMaterial({ color: 0x000000, wireframe: true })
    );

    scene.add(cube);

    camera.position.z = 5;

    var animate = function() {
      requestAnimationFrame(animate);

      if (this.props && this.props.NOWRotate) {
        cube.rotation.x += this.props.NOWRotate.xPos / 50;
        cube.rotation.y += this.props.NOWRotate.yPos / 50;
      }

      cube.position.z += this.props.scale;

      renderer.render(scene, camera);
    };

    animate = animate.bind(this);

    animate();
  }

  render() {
    return <div />;
  }
}

export default CanvasOne;
