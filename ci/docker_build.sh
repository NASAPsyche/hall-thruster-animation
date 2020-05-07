#!/usr/bin/env bash

set -e
echo hello
docker run \
  -e BUILD_NAME \
  -e UNITY_LICENSE_CONTENT \
  -e BUILD_TARGET \
  -e UNITY_USERNAME \
  -e UNITY_PASSWORD \
  -w /hall-thruster-animation/ \
  -v $(pwd):/hall-thruster-animation/ \
  $IMAGE_NAME \
  /bin/bash -c "/hall-thruster-animation/ci/before_script.sh && /hall-thruster-animation/ci/build.sh"
