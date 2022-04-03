FROM node:17-alpine

RUN wget -O /tmp/netdata-kickstart.sh https://my-netdata.io/kickstart.sh 
RUN sh /tmp/netdata-kickstart.sh --non-interactive --disable-cloud --dont-start-it

RUN mkdir -p /usr/src/nationservice

WORKDIR /usr/src/nationservice

COPY package.json /usr/src/nationservice
COPY package-lock.json /usr/src/nationservice

RUN npm install

COPY . /usr/src/nationservice

CMD ["sh", "/usr/src/nationservice/docker_startup.sh" ]