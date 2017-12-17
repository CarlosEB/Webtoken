"# WebToken" 

Simple example using .net Core and Docker:

To create webtoken image:

docker build -t webtoken-img -f webtoken.dockerfile .

To run webtoken

docker run --name webtoken -d -p 5000:5000 -t webtoken-img


Using Service:

docker service init

To create 1 worker

docker service create --publish 5000:5000 --replicas 1 --name webtoken webtoken-img

To scale the service: 

docker service scale webtoken=3

 docker service ps webtoken