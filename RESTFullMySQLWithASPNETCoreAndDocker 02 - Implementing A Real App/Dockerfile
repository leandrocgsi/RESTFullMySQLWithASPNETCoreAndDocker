FROM mysql:5.7.22
EXPOSE 3306
# COPY ./RESTFullMySQLWithASPNETCoreAndDocker/ci/init_database.sh /init_database.sh
# COPY ./RESTFullMySQLWithASPNETCoreAndDocker/ci/assets/my.cnf /etc/my.cnf

COPY ./RESTFullMySQLWithASPNETCoreAndDocker/db/migrations/ /home/database/
COPY ./RESTFullMySQLWithASPNETCoreAndDocker/db/dataset/ /home/database/
COPY ./RESTFullMySQLWithASPNETCoreAndDocker/ci/init_database.sh /docker-entrypoint-initdb.d/init_database.sh
# RUN sh /init_database.sh