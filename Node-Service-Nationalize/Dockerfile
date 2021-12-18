FROM node:17-alpine

RUN mkdir -p /usr/src/nationservice

WORKDIR /usr/src/nationservice

COPY package.json /usr/src/nationservice
COPY package-lock.json /usr/src/nationservice

RUN npm install

COPY . /usr/src/nationservice

EXPOSE 3000

CMD [ "npm", "start" ]