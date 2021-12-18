FROM node:17-alpine

RUN mkdir -p /usr/src/genderservice

WORKDIR /usr/src/genderservice

COPY package.json /usr/src/genderservice
COPY package-lock.json /usr/src/genderservice

RUN npm install

COPY . /usr/src/genderservice

EXPOSE 3000

CMD [ "npm", "start" ]