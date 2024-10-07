find . -name "*.cs" | while read file; do
sed -i '/\/\/.*/d' "$file"
sed -i ':a;N;$!ba;s/\/\*[^*]*\*\/\|\/\*[^*]*\*\/.*//g' "$file"
done
