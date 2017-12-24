for f in *.png
do
  echo "${f/ Copy \((\d+)\).png/\1.png}"
done
