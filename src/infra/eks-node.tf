resource "aws_eks_node_group" "eks-node" {
  cluster_name    = aws_eks_cluster.eks-cluster.name
  node_group_name = var.nodeGroup
  node_role_arn   = var.labRole
  subnet_ids      = [for subnet in data.aws_subnet.subnet : subnet.id if subnet.availability_zone != "${var.region}e"]
  disk_size       = 20
  instance_types  = [var.eksInstanceType]

  scaling_config {
    desired_size = 1
    min_size     = 1
    max_size     = 8
  }

  update_config {
    max_unavailable = 1
  }
}