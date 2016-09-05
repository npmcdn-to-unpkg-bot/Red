#!/bin/bash

docker-compose stop abc abc-tests
docker-compose rm -f abc abc-tests

docker-compose build abc abc-tests
docker-compose up -d abc
docker-compose up abc-tests
