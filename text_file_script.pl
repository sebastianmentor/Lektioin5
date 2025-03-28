open(my $fh, "<", "users.txt") or die "Kunde inte öppna filen!";
while (my $line = <$fh>) {
    print $line if $line =~ /admin/;
}
close($fh);
