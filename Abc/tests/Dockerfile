FROM docker-registry.meer-spacestation.co.uk/apickli:1.0.5.1

RUN mkdir -p /usr/abc/tests
COPY . /usr/abc/tests
WORKDIR /usr/abc/tests

RUN chmod u+x /usr/abc/tests/start.sh

CMD [ "./start.sh" ]
