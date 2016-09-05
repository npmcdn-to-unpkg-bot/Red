#!/bin/bash

PWD=`pwd`

docker run \
  --rm \
  --volume "$PWD:/build" \
  --workdir /build \
  mono:4.2 \
  bash ci-build/xbuild.sh
