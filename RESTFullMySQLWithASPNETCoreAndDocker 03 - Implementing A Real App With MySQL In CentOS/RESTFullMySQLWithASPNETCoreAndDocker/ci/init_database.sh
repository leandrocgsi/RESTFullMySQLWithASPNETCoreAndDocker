#!/usr/bin/env sh
set -e

yum -y update

# Instalar o MySQL 5.6
yum install -y wget
wget http://repo.mysql.com/mysql-community-release-el6-5.noarch.rpm -O /tmp/mysql-community-release-el6-5.noarch.rpm
rpm -ivh /tmp/mysql-community-release-el6-5.noarch.rpm
yum -y install mysql-server

# Inicialização do diretório de armazenamento do MySQL.
rm -rf /var/lib/mysql/*
chown -R mysql:mysql /var/lib/mysql
mysql_install_db --user=mysql --datadir="/var/lib/mysql" --rpm --keep-my-cnf

/etc/init.d/mysqld start

# Criação dos bancos de dados do sistema
mysqladmin create rest_with_asp_net_udemy

# Criação do usuário utilizado na conexão
mysql -e "CREATE USER 'docker'@'%' IDENTIFIED BY 'docker'" rest_with_asp_net_udemy
mysql -e "GRANT ALL PRIVILEGES ON rest_with_asp_net_udemy.* TO 'docker'@'%'" rest_with_asp_net_udemy

# Restauração dos bancos de dados

for i in `find -name "*.sql" | sort --version-sort`; do mysql -udocker -pdocker rest_with_asp_net_udemy < $i; done;

# Atribuição de permissões de acesso externo para o usuário root, senha docker
mysql -e "GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' IDENTIFIED BY 'docker' WITH GRANT OPTION;"

# Remover arquivos temporários
rm -rf /tmp/*
yum clean all

# Configuração de permissões de execução no script de inicialização do container
chmod +x /home/database/entrypoint.sh

exit 0

