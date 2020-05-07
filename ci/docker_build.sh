#!/usr/bin/env bash

set -e

docker run \
  -e BUILD_NAME \
  -e UNITY_LICENSE_CONTENT \
  -e BUILD_TARGET \
  -e UNITY_USERNAME \
  -e UNITY_PASSWORD \
  -w /hall-thruster-animation/ \
  $IMAGE_NAME \
  /bin/bash -c "/ci/before_script.sh && /ci/build.sh"
