for i in `find -name "*.sql" | sort --version-sort`; do mysql -udocker -pdocker rest_with_asp_net_udemy < $i; done;
