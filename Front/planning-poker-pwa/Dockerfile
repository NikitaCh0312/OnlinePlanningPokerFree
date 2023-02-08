FROM node:16.15.1-alpine

WORKDIR /app

COPY package.json /app

RUN npm install 
RUN npm install serve 

COPY . /app

RUN npm run build

ENV SERVER_API_URL="http://localhost:5000"

EXPOSE 3000

CMD [ "npx", "serve", "build" ]