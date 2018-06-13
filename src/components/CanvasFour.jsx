import React, { Component, Fragment } from "react";
import * as THREE from "three";

class CanvasFour extends Component {
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

    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    var cube = new THREE.Mesh(
      new THREE.SphereBufferGeometry(0.8, 16, 8),
      new THREE.MeshBasicMaterial({ color: 0x000000, wireframe: true })
    );

    cube.position.set(2, 0, 0);
    cube.rotation.set(0, 0, 0);

    var cube1 = new THREE.Mesh(
      new THREE.SphereBufferGeometry(0.8, 16, 8),
      new THREE.MeshBasicMaterial({ color: 0x000000, wireframe: true })
    );

    cube1.position.set(-2, 0, 0);
    cube1.rotation.set(0, -2, 0);

    var cube2 = new THREE.Mesh(
      new THREE.SphereBufferGeometry(0.8, 16, 8),
      new THREE.MeshBasicMaterial({ color: 0x000000, wireframe: true })
    );

    cube2.position.set(0, 2, 0);
    cube2.rotation.set(0, 0, 0);

    var cube3 = new THREE.Mesh(
      new THREE.SphereBufferGeometry(0.8, 16, 8),
      new THREE.MeshBasicMaterial({ color: 0x000000, wireframe: true })
    );

    cube3.position.set(0, -2, 0);
    cube3.rotation.set(0, -2, 0);

    scene.add(cube);
    scene.add(cube1);
    scene.add(cube2);
    scene.add(cube3);

    camera.position.z = 10;

    var animate = function() {
      requestAnimationFrame(animate);

      if (this.props && this.props.NOWRotate) {
        cube.rotation.x += this.props.NOWRotate.xPos / 50;
        cube.rotation.y += this.props.NOWRotate.yPos / 50;

        cube1.rotation.x += this.props.NOWRotate.xPos / 50;
        cube1.rotation.y += this.props.NOWRotate.yPos / 50;

        cube2.rotation.x += this.props.NOWRotate.xPos / 50;
        cube2.rotation.y += this.props.NOWRotate.yPos / 50;

        cube3.rotation.x += this.props.NOWRotate.xPos / 50;
        cube3.rotation.y += this.props.NOWRotate.yPos / 50;

        cube.position.z += this.props.scale;
        cube1.position.z += this.props.scale;
        cube2.position.z += this.props.scale;
        cube3.position.z += this.props.scale;
      }

      renderer.render(scene, camera);
    };

    animate = animate.bind(this);

    animate();
  }

  render() {
    return <div id="four" />;
  }
}

export default CanvasFour;
