my $target = "8.8.8.8";
my $output = `ping -c 4 $target`;
print $output;
