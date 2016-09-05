#!/bin/bash

cucumber-js \
  --tags ~@ignore \
  --require /usr/abc/tests/step_definitions \
  /usr/abc/tests/features
