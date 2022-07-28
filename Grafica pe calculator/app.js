import * as THREE from 'https://cdn.jsdelivr.net/npm/three@0.118/build/three.module.js';

import {FBXLoader} from 'https://cdn.jsdelivr.net/npm/three@0.118.1/examples/jsm/loaders/FBXLoader.js';
import {GLTFLoader} from 'https://cdn.jsdelivr.net/npm/three@0.118.1/examples/jsm/loaders/GLTFLoader.js';
import {OrbitControls} from 'https://cdn.jsdelivr.net/npm/three@0.118/examples/jsm/controls/OrbitControls.js';


let scene, camera, renderer, controls,street,fbxLoader,mixer,mixer2,mixer3,mixer4,mixer5,person;

let clock = new THREE.Clock();
let clock2 = new THREE.Clock();
let clock3 = new THREE.Clock();
let clock4 = new THREE.Clock();
let clock5 = new THREE.Clock();

function init() {
    // Crearea unei scene
    scene = new THREE.Scene();
    street = new THREE.Group();
    person = new THREE.Group();
    const loader = new GLTFLoader();
    scene.background = new THREE.Color(0xc8e0c8);
    const fbxLoader = new FBXLoader()
    var time = 0;

    //Camera init
    camera = new THREE.PerspectiveCamera(50, window.innerWidth / window.innerHeight, 1, 10000);
    camera.position.set(11, 1, 10);
    scene.add(camera);

    // Crearea unui renderer
    renderer = new THREE.WebGLRenderer({ antialias: true });

    renderer.setSize(window.innerWidth, window.innerHeight);

    // Randarea render-ului in documentul HTML
    document.body.appendChild(renderer.domElement);

    //Crearea unei variabile OrbitControls
    controls = new OrbitControls(camera, renderer.domElement);

    const light = createLights();
    //const light2 = new THREE.DirectionalLight('#365d7a', 6);
    //light2.position.set(-360, 180, -180);


    scene.add(light);
    //scene.add(light2);
    // scene.add(masa_scaun)
    scene.add(street);
    scene.add(person);

    //Strada
    loader.load('resources/street/scene.gltf', function (gltf) {
      gltf.scene.scale.set(0.006, 0.006, 0.006);
      gltf.scene.position.set(0.5, -0.1, -5);


      street.add(gltf.scene);


    }, undefined, function (error) {
        console.error(error);
    });

    //Strada2
    loader.load('resources/street/scene.gltf', function (gltf) {
        gltf.scene.scale.set(0.006, 0.006, 0.006);
        gltf.scene.position.set(-13.2, -0.1, 9.4);
        gltf.scene.rotation.set(0, -(1) * Math.PI, 0);
  
  
        street.add(gltf.scene);
  
  
      }, undefined, function (error) {
          console.error(error);
      });

    //Luna
    loader.load('resources/moon/scene.gltf', function (gltf) {
        gltf.scene.scale.set(0.01,0.01,0.01);
        gltf.scene.position.set(-15,7,-5);


        street.add(gltf.scene);


    }, undefined, function (error) {
        console.error(error);
    });


    //Dubita
    loader.load('resources/van/scene.gltf', function (gltf) {
        gltf.scene.scale.set(0.025, 0.025, 0.025);
        gltf.scene.position.set(4, -0.12, 1.5);
        gltf.scene.rotation.set(0,33,0);

        street.add(gltf.scene);


    }, undefined, function (error) {
        console.error(error);
    });
  
    //Dacia
    loader.load('resources/car/scene.gltf', function (gltf) {
      gltf.scene.scale.set(0.03, 0.03, 0.03);
      gltf.scene.position.set(-3, -0.15, 0.5);
      gltf.scene.rotation.set(0, 6.3, 0);

      street.add(gltf.scene);


  }, undefined, function (error) {
      console.error(error);
  });

  //Boombox
  loader.load('resources/boombox/scene.gltf', function (gltf) {
    gltf.scene.scale.set(1, 1, 1);
    gltf.scene.position.set(16, 0.5, 1);
    gltf.scene.rotation.set(0, 1, 0);

    street.add(gltf.scene);


}, undefined, function (error) {
    console.error(error);
});

 //Cladire1 tip 1
 loader.load('resources/building1/scene.gltf', function (gltf) {
  gltf.scene.scale.set(0.01, 0.01, 0.01);
  gltf.scene.position.set(-4, -0 , -4.3);
  gltf.scene.rotation.set(0, -(2) * Math.PI, 0);

  street.add(gltf.scene);


}, undefined, function (error) {
  console.error(error);
});

 //Cladire2 tip 1
 loader.load('resources/building1/scene.gltf', function (gltf) {
  gltf.scene.scale.set(0.01, 0.01, 0.01);
  gltf.scene.position.set(0.2, -0 , -4.3);
  gltf.scene.rotation.set(0, -(2) * Math.PI, 0);

  street.add(gltf.scene);


}, undefined, function (error) {
  console.error(error);
});


 //Cladire3 tip 2
 loader.load('resources/building2/scene.gltf', function (gltf) {
  gltf.scene.scale.set(2, 4, 2);
  gltf.scene.position.set(3.2, 0 , 9);
  gltf.scene.rotation.set(0, -(2) * Math.PI, 0);

  street.add(gltf.scene);


}, undefined, function (error) {
  console.error(error);
});


 //Cladire4 tip 2
 loader.load('resources/building2/scene.gltf', function (gltf) {
    gltf.scene.scale.set(2, 4, 2);
    gltf.scene.position.set(-4, 0 , 9);
    gltf.scene.rotation.set(0, -(2) * Math.PI, 0);
  
    street.add(gltf.scene);
  
  
  }, undefined, function (error) {
    console.error(error);
  });


    //Cal
    loader.load('resources/horse/scene.gltf', function (gltf) {
        gltf.scene.scale.set(0.0025, 0.0025, 0.0025);
        gltf.scene.position.set(1, 5.9, -4);
        gltf.scene.rotation.set(0,-30,0);
        street.add(gltf.scene);


    }, undefined, function (error) {
        console.error(error);
    });



    const loader_ch = new FBXLoader();
    const loader_ch2 = new FBXLoader();
    const loader_ch3 = new FBXLoader();
    const loader_ch4 = new FBXLoader();
    const loader_ch5 = new FBXLoader();
    loader_ch.load("resources/mickeymouse/Mickey.fbx", function (obj) {
        obj.scale.set(1, 1, 1);
        obj.position.set(3, -0.15 , 3.5);
        obj.rotation.set(0, -(1+3/4) * Math.PI, 0);


        mixer = new THREE.AnimationMixer(obj);

        const action = mixer.clipAction(obj.animations[1]);
        action.play();
        obj.traverse(function (c) {
            if (c.isMesh) {
                c.castShadow = true;
                c.receiveShadow = true;
            }
        });

        street.add(obj);
    });


    loader_ch2.load("resources/spiderman2.fbx", function (obj) {
      obj.scale.set(0.00009, 0.00009, 0.00009);
      obj.position.set(2, 0, 6);
      obj.rotation.set(0, -(3/4) * Math.PI, 0);
  
  
      mixer2 = new THREE.AnimationMixer(obj);
  
      const action = mixer2.clipAction(obj.animations[0]);
      action.play();
      obj.traverse(function (c) {
          if (c.isMesh) {
              c.castShadow = true;
              c.receiveShadow = true;
          }
      });
  
      street.add(obj);
  
  });


    loader_ch3.load("resources/rat.fbx", function (obj) {
      obj.scale.set(0.0009, 0.0009, 0.0009);
      obj.position.set(10, 0, 6);
      obj.rotation.set(0, -(3/4) * Math.PI, 0);


      mixer3 = new THREE.AnimationMixer(obj);

      const action = mixer3.clipAction(obj.animations[0]);
      action.play();
      obj.traverse(function (c) {
          if (c.isMesh) {
              c.castShadow = true;
              c.receiveShadow = true;
          }
      });

      street.add(obj);

  });


  
    
loader_ch4.load("resources/SantaBD.fbx", function (obj) {
      obj.scale.set(0.009, 0.009, 0.009);
      obj.position.set(16, 0, 2);
      obj.rotation.set(0, -(1/2) * Math.PI, 0);


      mixer4 = new THREE.AnimationMixer(obj);

      const action = mixer4.clipAction(obj.animations[0]);
      action.play();
      obj.traverse(function (c) {
          if (c.isMesh) {
              c.castShadow = true;
              c.receiveShadow = true;
          }
      });

      street.add(obj);

  });

  loader_ch5.load("resources/elonmusk.fbx", function (obj) {
    obj.scale.set(0.009, 0.009, 0.009);
    obj.position.set(16, 0, 6);
    obj.rotation.set(0, -(3/4) * Math.PI, 0);


    mixer5 = new THREE.AnimationMixer(obj);

    const action = mixer5.clipAction(obj.animations[0]);
    action.play();
    obj.traverse(function (c) {
        if (c.isMesh) {
            c.castShadow = true;
            c.receiveShadow = true;
        }
    });

    street.add(obj);

});

    controls.update();
}

function onDocumentKeyDown(event) {

    // up
    if (event.keyCode == 37) {
        person.position.z += 1;
        // down
    } else if (event.keyCode == 39) {
        person.position.z -= 1;
        // left
    } else if (event.keyCode == 38) {
        person.position.x -= 1;
        // right
    } else if (event.keyCode == 40) {
        person.position.x += 1;
        // space
    } else if (event.keyCode == 32) {
        person.position.x = 0.0;
        person.position.z = 0.0;
    }
    animate();
};

function createLights() {
    // Crearea unei lumini directionale
    const light = new THREE.DirectionalLight('#365d7a', 6);
    
    // Pozitionarea luminii
    light.position.set(360, 180, 180);
    

    return light;
}

function onWindowResize() {
    camera.aspect = window.innerWidth / window.innerHeight;
    camera.updateProjectionMatrix();
    renderer.setSize(window.innerWidth, window.innerHeight);
}


function animate() {
    requestAnimationFrame(animate);
    controls.update();

    renderer.render(scene, camera);
    if (mixer) mixer.update(clock.getDelta());
    if (mixer2) mixer2.update(clock2.getDelta());
    if (mixer3) mixer3.update(clock3.getDelta());
    if (mixer4) mixer4.update(clock4.getDelta());
    if (mixer5) mixer5.update(clock5.getDelta());
}
window.addEventListener('resize', onWindowResize, false);

init();

controls.enableKeys = true;
animate();
animate();
