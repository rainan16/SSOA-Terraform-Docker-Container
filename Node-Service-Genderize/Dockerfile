FROM node:17-alpine

RUN wget -O /tmp/netdata-kickstart.sh https://my-netdata.io/kickstart.sh 
RUN sh /tmp/netdata-kickstart.sh --non-interactive --disable-cloud --dont-start-it

RUN mkdir -p /usr/src/genderservice

WORKDIR /usr/src/genderservice

COPY package.json /usr/src/genderservice
COPY package-lock.json /usr/src/genderservice

RUN npm install

COPY . /usr/src/genderservice

COPY exporting.conf /opt/netdata/etc/netdata/exporting.conf

CMD ["sh", "/usr/src/genderservice/docker_startup.sh" ]