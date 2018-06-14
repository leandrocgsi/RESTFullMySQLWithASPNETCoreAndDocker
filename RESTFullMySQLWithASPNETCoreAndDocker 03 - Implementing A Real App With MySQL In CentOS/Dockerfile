FROM centos:centos7

ENV TERM xterm

COPY ./RESTFullMySQLWithASPNETCoreAndDocker/db/migrations/ /home/database/
COPY ./RESTFullMySQLWithASPNETCoreAndDocker/db/dataset/ /home/database/

COPY ./RESTFullMySQLWithASPNETCoreAndDocker/ci/assets/my.cnf /etc/my.cnf

COPY ./RESTFullMySQLWithASPNETCoreAndDocker/ci/init_database.sh /home/database/init_database.sh
COPY ./RESTFullMySQLWithASPNETCoreAndDocker/ci/entrypoint/entrypoint.sh /home/database/entrypoint.sh

# RUN sh /home/database/init_database.sh

EXPOSE 3306
# CMD ["/home/database/entrypoint.sh"]