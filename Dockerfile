FROM lojzik/rpi-aspnet:1.0.0-rc1-final

COPY . /app
WORKDIR /app/HomeDashboard/src/HomeDashboardWeb
RUN ["dnu", "restore"]

EXPOSE 5000
ENTRYPOINT ["dnx", "-p", "project.json", "web"]